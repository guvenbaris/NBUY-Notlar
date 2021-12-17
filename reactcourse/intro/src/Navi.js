import React from 'react';
import {
  Collapse,
  Navbar,
  NavbarToggler,
  NavbarBrand,
  Nav,
  NavItem,
  NavLink } from 'reactstrap';
import CartSummary from './CartSummary';

export default class Example extends React.Component {
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
                <NavLink href="/components/">Components</NavLink>
              </NavItem>
              <NavItem>
                <NavLink href="https://github.com/reactstrap/reactstrap">GitHub</NavLink>
              </NavItem>
             <CartSummary deneme = {this.props.cart}/>

            </Nav>
        </div>   
        </Navbar>
      </div>
    );
  }
}