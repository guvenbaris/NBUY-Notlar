import React from 'react';
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  NavLink } from 'reactstrap';



export default class Navi extends React.Component {
  constructor(props) {
    super(props);

    this.toggle = this.toggle.bind(this);
    this.state = {
      isOpen: false
    };
  }
  toggle() {
    this.setState({
      isOpen: !this.state.isOpen
    });
  }
  render() {
    return (
      <div>
        <Navbar color="light" light expand="md">
        <div>
        <NavbarBrand href="/">Northwind App</NavbarBrand>
        <NavbarToggler onClick={this.toggle} />
        </div>
        <div>
        <Collapse isOpen={this.state.isOpen} navbar></Collapse>
            <Nav className="ml-auto" navbar>
              <NavItem>
                <NavLink>
                Form Demo 1
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink>
                Form Demo 2
                </NavLink>
              </NavItem>
              <NavItem>
                <NavLink href="https://github.com/reactstrap/reactstrap">GitHub</NavLink>
              </NavItem>
            </Nav>
        </div>   
        </Navbar>
      </div>
    );
  }
}