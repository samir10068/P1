
async function getdata()
{
    let resp = await fetch("https://localhost:44333/api/User");
    let data = await resp.json()
    console.log (data);
}
async function loginB()
{
 
    let Username = document.getElementById("user").value;
    let password = document.getElementById("pass").value;
    let check = 
    {
        
        UserName : Username,
        Password : password
    }

  

    let fetchParams =
    {
    method : 'POST',
    body : JSON.stringify(check),
    headers : {"Content-Type":"application/json"}
    }

    let resp = await fetch("https://localhost:44333/api/login", fetchParams);
    let data = await resp.json();
    console.log(data)
    if (data === true) {

    let lresp = await fetch("https://localhost:44333/api/User/");
    let ldata = await lresp.json()
    console.log (ldata);
    sessionStorage.setItem('fullname', ldata.FullName);
      
    window.location.href = 'HomePage.html';
 
}
    else {
   alert ("Error")
    }

}
async function loadData()
{
	let resp = await fetch("https://localhost:44333/api/MixedData");
	let Employees = await resp.json()
console.log(Employees)

	let tableObj = document.getElementById("tbl")

	Employees.forEach(Employee => {

		//Create ALL td's objects
		let FirstNameTdObj = document.createElement("td");
		FirstNameTdObj.innerText = Employee.FirstName;
        
                let LastNameTdObj = document.createElement("td");
                LastNameTdObj.innerText = Employee.LastName;
        
                let NumOfActionsTdObj = document.createElement("td");
                NumOfActionsTdObj.innerText = Employee.NumOfActions;
        
                let DepartmentNameTdObj = document.createElement("td");
                DepartmentNameTdObj.innerText = Employee.DepartmentName;
        
                let MangerTdObj = document.createElement("td");
                MangerTdObj.innerText = Employee.Manger;
        



	  //Create tr object
		let trObj = document.createElement("tr");

		//Add the td's to the tr
		trObj.appendChild(FirstNameTdObj);
		trObj.appendChild(LastNameTdObj);
		trObj.appendChild(NumOfActionsTdObj);
		trObj.appendChild(DepartmentNameTdObj);
		trObj.appendChild(MangerTdObj);
	


		//Add the tr to the table body
		tableObj.appendChild(trObj);


	});

}
function DepartmentsB()
{
    window.location.href = 'Departmentpage.html';
}
function ShiftsB()
{ 
    window.location.href = 'ShiftsPage.html'

}
function EmployeesB()
{
    window.location.href = 'EmployeePage.html'

}
function HomeB()
{
    window.location.href = 'HomePage.html'

}
async function DepartmentsData()
{
	let resp = await fetch("https://localhost:44333/api/Department/");
	let Departments = await resp.json()
    console.log(Departments)

	let tableObj = document.getElementById("tbl")
i=0;
y=0;
	Departments.forEach(Department => {


		//Create ALL td's objects
		let NameTdObj = document.createElement("td");
		NameTdObj.innerText = Department.Name;
        
                let MangerNameTdObj = document.createElement("td");
                MangerNameTdObj.setAttribute("id", "MangerName");
                MangerNameTdObj.innerText = Department.Manger;
                
                
                let EditTdObj = document.createElement("button");
                EditTdObj.innerHTML = "Edit" ;
                EditTdObj.setAttribute("id", i = i+1 );
                EditTdObj.addEventListener("click", function () {
                    sessionStorage["gree"] = this.id;
	                location.href = 'EditDep.html';
                });

                let DeleteTdObj = document.createElement("button");
                DeleteTdObj.innerHTML = "Delete" ;
                DeleteTdObj.setAttribute("id", y = y+1 );
                   DeleteTdObj.addEventListener("click", function () {
                    sessionStorage["gree"] = this.id;
	                location.href = 'ShiftsPage.html';

        
                  });

	  //Create tr object
		let trObj = document.createElement("tr");

		//Add the td's to the tr
		trObj.appendChild(NameTdObj);
		trObj.appendChild(MangerNameTdObj);
        trObj.appendChild(EditTdObj);
        trObj.appendChild(DeleteTdObj);
	


		//Add the tr to the table body
		tableObj.appendChild(trObj);


	});
}
async function EmployeesData()
{
	let resp = await fetch("https://localhost:44333/api/Employee/");
	let Employees = await resp.json()
    console.log(Employees)

	let tableObj = document.getElementById("tbl")
i=0;
y=0;
Employees.forEach(Employee => {


		//Create ALL td's objects
		        let FirstNameTdObj = document.createElement("td");
		        FirstNameTdObj.innerText = Employee.FirstName;


                 let LastNameTdObj = document.createElement("td");
                LastNameTdObj.innerText = Employee.LastName;
        
                let StartWorkYearTdObj = document.createElement("td");
                StartWorkYearTdObj.innerText = Employee.StartWorkYear;

                let DepartmentIDTdObj = document.createElement("td");
               DepartmentIDTdObj.innerText = Employee.DepartmentID;
               
             
                
               let EditTdObj = document.createElement("button");
               EditTdObj.innerHTML = "Edit" ;
               EditTdObj.setAttribute("id", i = i+1 );
               EditTdObj.addEventListener("click", function () {
                   sessionStorage["gree"] = this.id;
                   location.href = 'EditEmployee.html';
               });

                let DeleteTdObj = document.createElement("button");
                DeleteTdObj.innerHTML = "Delete" ;
                DeleteTdObj.setAttribute("id", y = y+1 );
                   DeleteTdObj.addEventListener("click", function () {
                    sessionStorage["gree"] = this.id;
	                location.href = 'ShiftsPage.html';

        
        
                  });

	  //Create tr object
		let trObj = document.createElement("tr");

		//Add the td's to the tr
		trObj.appendChild(FirstNameTdObj);
		trObj.appendChild(LastNameTdObj);
		trObj.appendChild(StartWorkYearTdObj);
		trObj.appendChild(DepartmentIDTdObj);
        trObj.appendChild(EditTdObj);
        trObj.appendChild(DeleteTdObj);
	


		//Add the tr to the table body
		tableObj.appendChild(trObj);


	});
}
async function ShiftsData()
{
	let resp = await fetch("https://localhost:44333/api/Shift/");
	let Shifts = await resp.json()
    console.log(Shifts)

	let tableObj = document.getElementById("tbl")
i=0;
y=0;
Shifts.forEach(Shift => {


		//Create ALL td's objects
		        let DateTdObj = document.createElement("td");
		        DateTdObj.innerText = Shift.Date;


                 let StartTimeTdObj = document.createElement("td");
                StartTimeTdObj.innerText = Shift.StartTime;
        
                let EndTimeTdObj = document.createElement("td");
                EndTimeTdObj.innerText = Shift.EndTime;

                
               let EditTdObj = document.createElement("button");
               EditTdObj.innerHTML = "Edit" ;
               EditTdObj.setAttribute("id", i = i+1 );
               EditTdObj.addEventListener("click", function () {
                   sessionStorage["gree"] = this.id;
                   location.href = 'EditShifts.html';
               });

                let DeleteTdObj = document.createElement("button");
                DeleteTdObj.innerHTML = "Delete" ;
                DeleteTdObj.setAttribute("id", y = y+1 );
                   DeleteTdObj.addEventListener("click", function () {
                    sessionStorage["gree"] = this.id;
	                location.href = 'ShiftsPage.html';

        
        
                  });

	  //Create tr object
		let trObj = document.createElement("tr");

		//Add the td's to the tr
		trObj.appendChild(DateTdObj);
		trObj.appendChild(StartTimeTdObj);
		trObj.appendChild(EndTimeTdObj);
        trObj.appendChild(EditTdObj);
        trObj.appendChild(DeleteTdObj);
	


		//Add the tr to the table body
		tableObj.appendChild(trObj);


	});
}
async function Editdep()
{

	let data =  sessionStorage["gree"];
	alert(data)
	    let resp = await fetch("https://localhost:44333/api/Department/" + data)
	    let dep = await resp.json();
	    console.log(dep);
        document.getElementById("Name").value = dep.Name;
    	document.getElementById("Manger").value = dep.Manger;
}
async function UpdateDep()
{
    let data =  sessionStorage["gree"];
	alert(data)
	let NameValue = document.getElementById("Name").value;
	let MangerValue = document.getElementById("Manger").value;
	


	let obj = {     Name : NameValue,
					Manger : MangerValue,
				
			  }


			let fetchParams = { method : 'PUT',
													body :JSON.stringify(obj),
													headers : {"Content-Type" : "application/json"}
					}

			let resp = await fetch("https://localhost:44333/api/Department/" + data, fetchParams);
			let status = await resp.json();
			alert(status)

			location.href = 'DepartmentsPage.html'

}
async function DeleteDep()
{
          let data =  sessionStorage["gree"];

			let fetchParams = { method : 'DELETE',
													headers : {"Content-Type" : "application/json"}
					}

			let resp = await fetch("https://localhost:44333/api/Department/" + data, fetchParams);
			let status = await resp.json();
			

			location.href = 'DepartmentPage.html'

}
async function EditEmp()
{

	let data =  sessionStorage["gree"];
	alert(data)
	    let resp = await fetch("https://localhost:44333/api/Employee" + data)
	    let emp = await resp.json();
	    console.log(emp);
        document.getElementById("FirstName").value = emp.FirstName;
    	document.getElementById("LastName").value = emp.LastName;
        document.getElementById("StartWorkYear").value = emp.StartWorkYear;
    	document.getElementById("DepartmentID").value = emp.DepartmentID;
}
async function UpdateEmp()
{
    let data =  sessionStorage["gree"];
	alert(data)
	let FirstNameValue = document.getElementById("FirstName").value;
	let LastNameValue = document.getElementById("Lastname").value;
	let StartWorkYearValue = document.getElementById("StartWorkYear").value;
	let DepartmentIDValue = document.getElementById("DepartmentID").value;
	


	let obj = {     FirstNameName : FirstNameValue,
					LastName : LastNameValue,
                    StartWorkYear : StartWorkYearValue,
                    DepartmentID : DepartmentIDValue
			  }


			let fetchParams = { method : 'PUT',
													body :JSON.stringify(obj),
													headers : {"Content-Type" : "application/json"}
					}

			let resp = await fetch("https://localhost:44333/api/Employee/" + data, fetchParams);
			let status = await resp.json();
			alert(status)

			location.href = 'EmployeesPage.html'

}
async function DeleteEmp()
{
          let data =  sessionStorage["gree"];
			let fetchParams = { method : 'DELETE',
													headers : {"Content-Type" : "application/json"}
					}

			let resp = await fetch("https://localhost:44333/api/Employee/" + data, fetchParams);
			let status = await resp.json();
			alert(status)

			location.href = 'EmployeePage.html'

}
async function Editstf()
{

	let data =  sessionStorage["gree"];
	alert(data)
	    let resp = await fetch("https://localhost:44333/api/Shits/" + data)
	    let sft = await resp.json();
	    console.log(sft);
        document.getElementById("Date").value = sft.Date;
    	document.getElementById("StartTime").value = sft.StartTime;
    	document.getElementById("EndTime").value = sft.EndTime;
}
async function Updatesft()
{
    let data =  sessionStorage["gree"];
	alert(data)
	let DateValue = document.getElementById("Date").value;
	let StartTimeValue = document.getElementById("StartTime").value;
	let EndTimeValue = document.getElementById("EndTime").value;
	


	let obj = {     Date : NameValue,
                    StartTime : MangerValue,
                    EndTime :EndTimeValue
			  }


			let fetchParams = { method : 'PUT',
													body :JSON.stringify(obj),
													headers : {"Content-Type" : "application/json"}
					          }

			let resp = await fetch("https://localhost:44333/api/Shifts/" + data, fetchParams);
			let status = await resp.json();
			alert(status)

			location.href = 'ShiftsPage.html'

}
async function Deletestf()
{
          let data =  sessionStorage["gree"];
			let fetchParams = { method : 'DELETE',
													headers : {"Content-Type" : "application/json"}
					}

			let resp = await fetch("https://localhost:44333/api/Shifts/" + data, fetchParams);
			let status = await resp.json();
			alert(status)

			location.href = 'ShiftsPage.html'

}
async function CDepartmentB()
{
	window.location.href = 'NewEmp.html'
}
async function SaveDep()
{
  let obj = {ID : parseInt(document.getElementById("id").value),
            FirstName : document.getElementById("FirstName").value,
            LastName : document.getElementById("LastName").value,
            StartWorkYear : document.getElementById("StartWorkYear").value,
            DepartmentID : document.getElementById("DepartmentID").value
		}

						
    let fetchParams = {method : 'POST',
                      body : JSON.stringify(obj),
                      headers : {"Content-Type" : "application/json"}
                      }

    let resp = await fetch("https://localhost:44333/api/Department",fetchParams);
    let data =  await resp.json()

		console.log(data)
		location.href = 'DepartmentsPage.html'
}
async function CEmployeeB()
{
	window.location.href = 'NewDep.html'
}
async function SaveEmp()
{
  let obj = {ID : parseInt(document.getElementById("id").value),
            Name : document.getElementById("Name").value,
            Manger : document.getElementById("Manger").value}

						
    let fetchParams = {method : 'POST',
                      body : JSON.stringify(obj),
                      headers : {"Content-Type" : "application/json"}
                      }

    let resp = await fetch("https://localhost:44333/api/Employee",fetchParams);
    let data =  await resp.json()

		console.log(data)
		location.href = 'EmployeePage.html'
}
async function CshiftB()
{
	window.location.href = 'Newsft.html'
}
async function Savesft()
{
  let obj = {ID : parseInt(document.getElementById("id").value),
            DateStartTime : document.getElementById("DateStartTime").value,
            StartTime : document.getElementById("StartTime").value,
            EndTime : document.getElementById("EndTime").value,}

						
    let fetchParams = {method : 'POST',
                      body : JSON.stringify(obj),
                      headers : {"Content-Type" : "application/json"}
                      }

    let resp = await fetch("https://localhost:44333/api/Shifts",fetchParams);
    let data =  await resp.json()

		console.log(data)
		location.href = 'ShiftsPage.html'
}







