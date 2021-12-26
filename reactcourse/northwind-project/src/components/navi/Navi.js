import React from "react";
import { Link } from "react-router-dom";

import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  NavLink,
} from "reactstrap";

import CartSummary from "../cart/CartSummary";

export default class Navi extends React.Component {
  constructor(props) {
    super(props);

    this.toggle = this.toggle.bind(this);
    this.state = {
      isOpen: false,
    };
  }
  toggle() {
    this.setState({
      isOpen: !this.state.isOpen,
    });
  }
  render() {
    return (
      <div>
        <Navbar color="light" light expand="md">
          <div>
            <NavbarBrand ><Link to="/">Northwind Mağazası</Link></NavbarBrand>
            <NavbarToggler onClick={this.toggle} />
          </div>
          <div>
            <Collapse isOpen={this.state.isOpen} navbar></Collapse>
            <Nav className="ml-auto" navbar>
              <NavItem> 
                <NavLink><Link to="/saveProduct">Ürün Ekle</Link></NavLink>
              </NavItem>
              <NavItem>
                <NavLink>Form Demo 2</NavLink>
              </NavItem>
              <CartSummary></CartSummary>

              <NavItem>
                <NavLink href="https://github.com/guvenbaris">GitHub</NavLink>
              </NavItem>
            </Nav>
          </div>
        </Navbar>
      </div>
    );
  }
}
