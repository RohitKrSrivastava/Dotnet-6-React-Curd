import React, { memo } from "react";
import { Route, Switch } from "react-router-dom";
import Home from "./home/Home";
import Employees from "./employee/Employees";
import EditEmployee from "./employee/EditEmployee";
import AddEmployee from "./employee/AddEmployee";
import Cafes from "./cafe/Cafes";


function Routing(props) {
  return (
    <Switch>
      <Route exact path="/employees" component={Employees} />
      <Route path="/employees/add" component={AddEmployee} exact />
      <Route path="/employees/:id" component={EditEmployee} exact />
      <Route path="/cafes" component={Cafes} exact />
      <Route path="/" component={Home} />
    </Switch>
  );
}
export default memo(Routing);
