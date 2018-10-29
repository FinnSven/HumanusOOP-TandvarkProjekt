import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export class NavMenu extends Component {
    constructor(props) {
        super(props);
    }
  displayName = NavMenu.name

    render() {
        
        
    return (
      <Navbar inverse fixedTop fluid collapseOnSelect>
        <Navbar.Header>
          <Navbar.Brand>
            <Link to={'/'}>TandVark_ASP.NETCORE_REACT</Link>
          </Navbar.Brand>
          <Navbar.Toggle />
        </Navbar.Header>
            <Navbar.Collapse>
                {

                }
          <Nav>
            <LinkContainer to={'/'} exact>
              <NavItem>
                <Glyphicon glyph='home' /> Home
              </NavItem>
                    </LinkContainer>

                    
                    
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
