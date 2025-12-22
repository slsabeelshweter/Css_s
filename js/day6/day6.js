  async function loadUsers() {
        let response = await fetch("https://6947b569ca6715d122fadc09.mockapi.io/users");
        let data = await response.json();

        let tableBody = document.getElementById("usersBody");
        let rows = ""; 

        for (let i = 0; i < data.length; i++) {
            rows += "<tr>";
            rows += "<td>" + data[i].id + "</td>";
            rows += "<td>" + data[i].name + "</td>";
            rows += "<td>" + data[i].email + "</td>";
            rows += "<td><img src='" + data[i].avatar + "' width='50'></td>";
            rows += "<td>" + data[i].createdAt + "</td>";
            rows += "</tr>";
        }

        tableBody.innerHTML = rows;
    }

    loadUsers();