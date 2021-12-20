import { Container } from "reactstrap";
import Dashboard from "./Dashboard";
import Navi from "../navi/Navi";
import React from 'react';
function App() {
  return (
    <Container>
      <Navi></Navi>
      <Dashboard></Dashboard>
    </Container>
  );
}

export default App;
