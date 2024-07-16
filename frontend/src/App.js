import { useState } from 'react';
import './App.css';

function App() {
  const submitHandler = async (e) => {
    e.preventDefault();

    const data = {
      name,
      surname,
      location,
      email,
      phoneNumber,
      summary,
      school,
      department,
      gpa,
      startDate,
      endDate,
      school2,
      department2,
      gpa2,
      startDate2,
      endDate2,
      experience,
      position,
      experienceStartDate,
      experienceEndDate,
      keySkill,
      keySkill2,
      experience2,
      position2,
      experienceStartDate2,
      experienceEndDate2,
      keySkill3,
      keySkill4,
      Certificate1,
      Certificate2,
      Certificate3,
      Certificate4,
      linkedin,
      github
    };

    try {
      console.log(data.Certificate1)
      let response = await fetch("https://localhost:7287/cv", {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
      });

      

      const blob = await response.blob();
      const url = window.URL.createObjectURL(blob);

  
      const a = document.createElement('a');
      a.style.display = 'none';
      a.href = url;
      a.download = `cv.docx`;


      document.body.appendChild(a);

  
      a.click();


      window.URL.revokeObjectURL(url);
      document.body.removeChild(a)



      
      console.log(response.body)
    } catch (error) {
      console.error('Error:', error);
    }
  }

  const [name, setName] = useState("");
  const [surname, setSurname] = useState("");
  const [location, setLocation] = useState("");
  const [email, setEmail] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [summary, setSummary] = useState("");

  const [school, setSchool] = useState("");
  const [department, setDepartment] = useState("");
  const [gpa, setGpa] = useState("");
  const [startDate, setStartDate] = useState("");
  const [endDate, setEndDate] = useState("");

  const [school2, setSchool2] = useState("");
  const [department2, setDepartment2] = useState("");
  const [gpa2, setGpa2] = useState("");
  const [startDate2, setStartDate2] = useState("");
  const [endDate2, setEndDate2] = useState("");

  const [experience, setExperience] = useState("");
  const [position, setPosition] = useState("");
  const [experienceStartDate, setExperienceStartDate] = useState("");
  const [experienceEndDate, setExperienceEndDate] = useState("");
  const [keySkill, setKeySkill] = useState("");
  const [keySkill2, setKeySkill2] = useState("");

  const [experience2, setExperience2] = useState("");
  const [position2, setPosition2] = useState("");
  const [experienceStartDate2, setExperienceStartDate2] = useState("");
  const [experienceEndDate2, setExperienceEndDate2] = useState("");
  const [keySkill3, setKeySkill3] = useState("");
  const [keySkill4, setKeySkill4] = useState("");

  const [Certificate1,set1] = useState("");
  const [Certificate2,set2] = useState("");
  const [Certificate3,set3] = useState("");
  const [Certificate4,set4] = useState("");

  const [linkedin,setlinkedin] = useState("");
  const [github,setgithub] = useState("");

  return (
    <div className='body'>
      <form className='form' onSubmit={submitHandler}>
        <h4>Personal Information</h4>
        <div className='part' id='about'>
          <div className='section'>
            <label htmlFor='name'>Name</label>
            <input type='text' onChange={(e)=> setName(e.target.value)}></input>
            <label htmlFor='surname'>Surname</label>
            <input type='text' onChange={(e)=> setSurname(e.target.value)}></input>
            <label htmlFor='location'>Location</label>
            <input type='text' onChange={(e)=> setLocation(e.target.value)}></input>
            <label htmlFor='email'>Email</label>
            <input type='email' onChange={(e)=> setEmail(e.target.value)}></input>
            <label htmlFor='phoneNumber'>Phone Number</label>
            <input type='tel' onChange={(e)=> setPhoneNumber(e.target.value)}></input>
            <label htmlFor='summary'>Summary</label>
            <textarea onChange={(e)=> setSummary(e.target.value)}></textarea>
          </div>

          <div className='section'>
            <label htmlFor='certificate1'>LınkedIn Link</label>
            <input type='text' onChange={(e)=> setlinkedin(e.target.value)}></input>
            <label htmlFor='certificate1'>GitHub Link</label>
            <input type='text' onChange={(e)=> setgithub(e.target.value)}></input>
           
            
            <button onSubmit={submitHandler} id='button'>Create CV</button>
            
          </div>
        </div>
        <h4>Education</h4>
        <div className='part' id='education'>
          <div className='section'>
            <label htmlFor='school'>School</label>
            <input type='text' onChange={(e)=> setSchool(e.target.value)}></input>
            <label htmlFor='department'>Department</label>
            <input type='text' onChange={(e)=> setDepartment(e.target.value)}></input>
            <label htmlFor='gpa'>GPA / 4</label>
            <input type='text' onChange={(e)=> setGpa(e.target.value)}></input>
            <label htmlFor='startDate'>Start Date</label>
            <input type='text' onChange={(e)=> setStartDate(e.target.value)}></input>
            <label htmlFor='endDate'>End Date</label>
            <input type='text' onChange={(e)=> setEndDate(e.target.value)}></input>
          </div>

          <div className='section'>
            <label htmlFor='certificate1'>Certificate 1</label>
            <input type='text' onChange={(e)=> set1(e.target.value)}></input>
            <label htmlFor='certificate1'>Certificate 2</label>
            <input type='text' onChange={(e)=> set2(e.target.value)}></input>
            <label htmlFor='certificate1'>Certificate 3</label>
            <input type='text' onChange={(e)=> set3(e.target.value)}></input>
            <label htmlFor='certificate1'>Certificate 4</label>
            <input type='text' onChange={(e)=> set4(e.target.value)}></input>
            
            
          </div>
        </div>
        <h4>Experience</h4>
        <div className='part' id='experience'>
          <div className='section'>
            <label htmlFor='experience'>Company</label>
            <input type='text' onChange={(e)=> setExperience(e.target.value)}></input>
            <label htmlFor='position'>Position</label>
            <input type='text' onChange={(e)=> setPosition(e.target.value)}></input>
            <label htmlFor='experienceStartDate'>Start Date</label>
            <input type='text' onChange={(e)=> setExperienceStartDate(e.target.value)}></input>
            <label htmlFor='experienceEndDate'>End Date</label>
            <input type='text' onChange={(e)=> setExperienceEndDate(e.target.value)}></input>
            <label htmlFor='keySkill'>Key Skill</label>
            <input type='text' onChange={(e)=> setKeySkill(e.target.value)}></input>
            <label htmlFor='keySkill2'>Key Skill</label>
            <input type='text' onChange={(e)=> setKeySkill2(e.target.value)}></input>
          </div>

          <div className='section'>
            <label htmlFor='experience2'>Company (2)</label>
            <input type='text' onChange={(e)=> setExperience2(e.target.value)}></input>
            <label htmlFor='position2'>Position (2)</label>
            <input type='text' onChange={(e)=> setPosition2(e.target.value)}></input>
            <label htmlFor='experienceStartDate2'>Start Date (2)</label>
            <input type='text' onChange={(e)=> setExperienceStartDate2(e.target.value)}></input>
            <label htmlFor='experienceEndDate2'>End Date (2)</label>
            <input type='text' onChange={(e)=> setExperienceEndDate2(e.target.value)}></input>
            <label htmlFor='keySkill3'>Key Skill (2)</label>
            <input type='text' onChange={(e)=> setKeySkill3(e.target.value)}></input>
            <label htmlFor='keySkill4'>Key Skill (2)</label>
            <input type='text' onChange={(e)=> setKeySkill4(e.target.value)}></input>
          </div>
        </div>

        
      </form>
    </div>
  );
}

export default App;
