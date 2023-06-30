import React, { useContext, useState, useEffect } from "react";
import { useHistory } from "react-router-dom";
import axios from "axios";
import {
  Box,
  Button,
  FormControl,
  FormGroup,
  FormHelperText,
  InputLabel,
  Input,
  Typography,
  FormLabel,
  RadioGroup,
  FormControlLabel,
  Radio,
  Select,
  MenuItem,
} from "@mui/material";
import { GlobalContext } from "../../context/GlobalState";

const apiUrl = process.env.REACT_APP_END_POINT;

function EmployeeForm({ initialValues, action }) {
  const [employee, setEmployee] = useState(initialValues);
  const [cafeList, setCafeList] = useState([]);
  const { addEmployee, editEmployee } = useContext(GlobalContext);
  const history = useHistory();

  useEffect(() => {
    setEmployee(initialValues);
    getAssignedCafe();
  }, [initialValues]);

  const getAssignedCafe = async () => {
    try {
      const response = await axios.get(
        `${apiUrl}/Cafe/allCafeList`
      );
      const cafes = response.data.map((cafe) => (
        <MenuItem key={cafe.id} value={cafe.id}>
          {cafe.name}
        </MenuItem>
      ));
      setCafeList(cafes);
    } catch (error) {
      console.log(error);
    }
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setEmployee((prevEmployee) => ({
      ...prevEmployee,
      [name]: value,
    }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (action === "Edit") {
      editEmployee(employee);
    } else {
      addEmployee(employee);
    }
    history.push("/employees");
  };

  return (
    <Box maxWidth={400} mx="auto" marginTop={4} marginBottom={4}>
      <Typography variant="h6" gutterBottom>
        {action === "Edit" ? "Edit Employee" : "Add Employee"}
      </Typography>
      <form onSubmit={handleSubmit}>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="name">Name</InputLabel>
          <Input
            id="name"
            name="name"
            value={employee.name}
            onChange={handleChange}
          />
        </FormControl>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="emailAddress">Email Address</InputLabel>
          <Input
            id="emailAddress"
            name="emailAddress"
            type="email"
            value={employee.emailAddress}
            onChange={handleChange}
          />
        </FormControl>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="phoneNumber">Phone Number</InputLabel>
          <Input
            id="phoneNumber"
            name="phoneNumber"
            type="tel"
            value={employee.phoneNumber}
            onChange={handleChange}
          />
        </FormControl>
        <FormGroup>
          {/* <FormControl margin="normal" required fullWidth>
            <InputLabel htmlFor="daysWorked">Days Worked in Cafe</InputLabel>
            <Input
              id="daysWorked"
              name="daysWorked"
              type="number"
              value={employee.daysWorked}
              onChange={handleChange}
            />
            <FormHelperText>
              Number of days the employee has worked in the cafe.
            </FormHelperText>
          </FormControl> */}
          <FormControl>
            <FormLabel>Gender</FormLabel>
            <RadioGroup
              defaultValue={employee.gender}
              id="gender"
              name="gender"
            >
              <FormControlLabel
                value="1"
                control={<Radio />}
                label="Female"
              />
              <FormControlLabel 
                value="2" 
                control={<Radio />} 
                label="Male" />
              <FormControlLabel
                value="3"
                control={<Radio />}
                label="Other"
              />
            </RadioGroup>
          </FormControl>
          <FormControl margin="normal" required fullWidth>
            <InputLabel id="cafeId">Assigned Cafe</InputLabel>
            <Select
              name="cafeId"
              id="cafeId"
              value={employee.cafeId}
              label="AssignedCafe"
              onChange={handleChange}
            >
              {cafeList}
            </Select>
          </FormControl>
        </FormGroup>
        <Button type="submit" variant="contained" color="primary">
          {action === "Edit" ? "Save Changes" : "Add Employee"}
        </Button>
      </form>
    </Box>
  );
}

export default EmployeeForm;
