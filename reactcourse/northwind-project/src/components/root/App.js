import { Container } from "reactstrap";
import Dashboard from "./Dashboard";
import Navi from "../navi/Navi";
import React from 'react';
import { Route, Routes } from "react-router-dom";
import CartDetail from "../cart/CartDetail";

function App() {
  return (
    <Container>
      <Navi></Navi>
      <Routes>
        <Route path="/" element={<Dashboard/>}></Route>
        <Route path="/product" element={<Dashboard/>} ></Route>
        <Route path="/cart" element={<CartDetail/>} ></Route>

      </Routes>
    </Container>
  );
}

export default App;
