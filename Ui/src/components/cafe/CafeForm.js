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

function CafeForm({ initialValues, action }) {
  const [cafe, setEmployee] = useState(initialValues);
  const [cafeList, setCafeList] = useState([]);
  const { addCafe, editCafe } = useContext(GlobalContext);
  const history = useHistory();

  useEffect(() => {
    setEmployee(initialValues);
    getAssignedCafe();
  }, [initialValues]);

  const getAssignedCafe = async () => {
    try {
      const response = await axios.get(
        "https://6496d62183d4c69925a32706.mockapi.io/Example/getDropdown"
      );
      const cafes = response.data.map((cafe, index) => (
        <MenuItem key={index} value={cafe}>
          {cafe}
        </MenuItem>
      ));
      setCafeList(cafes);
    } catch (error) {
      console.log(error);
    }
  };

  useEffect(() => {
    setEmployee(initialValues);
    getAssignedCafe();
  }, [initialValues]);

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
      editCafe(cafe);
    } else {
      addCafe(cafe);
    }
    history.push("/cafe");
  };

  return (
    <Box maxWidth={400} mx="auto" marginTop={4} marginBottom={4}>
      <Typography variant="h6" gutterBottom>
        {action === "Edit" ? "Edit Employee" : "Add Employee"}
      </Typography>
      <form onSubmit={handleSubmit}>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="name">Cafe Name</InputLabel>
          <Input
            id="name"
            name="name"
            value={cafe.name}
            onChange={handleChange}
          />
        </FormControl>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="discrption">Discription</InputLabel>
          <Input
            id="email"
            name="discrption"
            value={cafe.discription}
            onChange={handleChange}
          />
        </FormControl>
        <FormControl margin="normal" required fullWidth>
          <InputLabel htmlFor="location">Location</InputLabel>
          <Input
            id="phone"
            name="location"
            value={cafe.location}
            onChange={handleChange}
          />
        </FormControl>
        <FormGroup>
          <FormControl margin="normal" required fullWidth>
            <InputLabel htmlFor="daysWorked">Logo</InputLabel>
            <Input
              id="daysWorked"
              name="logo"
              value={cafe.logo}
              onChange={handleChange}
            />
            <FormHelperText>
              Number of days the employee has worked in the cafe.
            </FormHelperText>
          </FormControl>
        </FormGroup>
        <Button type="submit" variant="contained" color="primary">
          {action === "Edit" ? "Save Changes" : "Add Employee"}
        </Button>
      </form>
    </Box>
  );
}

export default CafeForm;
