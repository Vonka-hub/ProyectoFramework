document.getElementById("taskForm").addEventListener("submit", function (event) {
    event.preventDefault();

    const formData = new FormData(this);
    const data = Object.fromEntries(formData.entries());

    // Get UserId from hidden field
    data.UserId = document.getElementById("userId").value;
    formData.forEach((value, key) => {

        data[key] = value;
    });
    data["due_date"] = data.DueDate;
    data["start_date"] = data.StartDate;
    console.log(data);
    fetch('/Task/CreateTask', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data),
    })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                alert(data.message);
                // Optional: Reset the form or redirect
                document.getElementById("taskForm").reset();
            } else {
                alert("Error: " + data.error);
            }
        })
        .catch(error => {
            alert("An error occurred while creating the task.");
            console.error('Error:', error);
            
        });
});
