import React, { Component } from 'react';
import './Dentist.css';



export class Dentist_Main extends Component {
    constructor(props) {
        super(props);
       
    }
    handleLoginClick(credentials) {

        console.log(credentials[0].userName);
        console.log(credentials[0].passWord);

        fetch("api/Authentication/AuthenticateUser", {
            method: "post",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },

            //make sure to serialize your JSON body
            body: JSON.stringify({
                UserName: credentials[0].userName,
                PassWord: credentials[0].passWord
            })
        })
            .then((response) => {
                console.log(response);
                //do something awesome that makes the world a better place
            });
        
        console.log(credentials);
    }

    render() {

        return ( 
            <div className="DMain">
                <Dentist_Sub
                    onLoginClick={this.handleLoginClick}
                />
            </div>
            );
    }
}



export class Dentist_Sub extends Component {
    constructor(props) {
        super(props);
        this.state = {
            userName: "",
            passWord: ""
        }
        this.handleLoginClick = this.handleLoginClick.bind(this);
        this.handleUserNameOnChange = this.handleUserNameOnChange.bind(this);
        this.handlePassWordOnChange = this.handlePassWordOnChange.bind(this);

    }


    handleLoginClick() {
        var credentials = [{ userName: this.state.userName, passWord: this.state.passWord }];
        this.props.onLoginClick(credentials);
    }
    handleUserNameOnChange(e) {
        console.log(e.target.value);
        this.setState({ userName: e.target.value });
    }
    handlePassWordOnChange(e) {
        this.setState({ passWord: e.target.value });
    }


    render() {

        return (
            <div className="DSub">

                <input type="text" onChange={this.handleUserNameOnChange}/>
                <input type="text" onChange={this.handlePassWordOnChange}/>

                <button onClick={this.handleLoginClick}>login</button>
                <button>cancel</button>
            </div>
        );
    }
}