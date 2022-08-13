import * as React from 'react'
import './App.css';
import { useState } from 'react';
import Login from './forms/login-form';
import Splash from './main/splash';
import Home from './main/home';
import Deposit from './main/deposit';
import Navbar from './header/navbar';
import Withdraw from './main/withdraw';
import Transfer from './main/transfer';
import Statements from './main/statements';
import Profile from './main/profile';
import { BrowserRouter, Link, Route, Router, Routes } from "react-router-dom";


interface LogInDetails {
  userID: number;
  userEmail: string;
  userEmailVerified: boolean;
  userPostCode: number;
}


function App() {

  const [splashVisible, setSplashVisible] = useState(true);
  const [homeVisible, setHomeVisible] = useState(false);
  const [depositVisible, setDepositVisible] = useState(false);
  const [transferVisible, setTransferVisible] = useState(false);
  const [withdrawVisible, setWithdrawVisible] = useState(false);
  const [statementsVisible, setStatementsVisible] = useState(false);
  const [profileVisible, setProfileVisible] = useState(false);

  const [splashDisabled, setSplashDisabled] = useState(false);

  const [homeDisabled, setHomeDisabled] = useState(false);

  const onShowHome = () => { setHomeVisible(true)
    setSplashVisible(false)} ;

  const onLogout = () => { setHomeVisible(false)
    setSplashVisible(true)} ;

  const [depositDisabled, setDepositDisabled] = useState(false);
  const onShowDeposit = () => setDepositVisible(true);
  const onDepositClose = () => setDepositVisible(false);

  const [withdrawDisabled, setWithdrawDisabled] = useState(false);
  const onShowWithdraw = () => setWithdrawVisible(true);
  const onWithdrawClose = () => setWithdrawVisible(false);

  const [transferDisabled, setTransferDisabled] = useState(false);
  const onShowTransfer = () => setTransferVisible(true);
  const onTransferClose = () => setTransferVisible(false);

  const [statementsDisabled, setStatementsDisabled] = useState(false);
  const onShowStatements = () => setStatementsVisible(true);
  const onStatementsClose = () => setStatementsVisible(false);

  const [profileDisabled, setProfileDisabled] = useState(false);
  const onShowProfile = () => setProfileVisible(true);
  const onProfileClose = () => setProfileVisible(false);



  
  const onLogin = (props:LogInDetails) =>{ 
      
    // client operations here
  }




  //SEPARATE APP.JS into two files for each ROUTE

  //HALF OF EVERYTHING IN SPLASH.tsx and the other in HOME.TSX

  //COMPLETE ROUTING IN INDEX.TSX


  return (
      <div className="App">
        <div>


          <Splash
            onLogin ={onLogin}
          />

          <Navbar
            toggleDeposit={onShowDeposit}
            toggleDepositClose={onDepositClose}
            toggleWithdraw={onShowWithdraw}
            toggleTransfer={onShowTransfer}
            toggleStatements={onShowStatements}
            toggleProfile={onShowProfile}
            logout={onLogout}
            
          />
            
          <Home
          disabled = {homeDisabled}
          visible = {homeVisible}
          onLogout ={onLogout}
            
          
          />

          <Deposit
            disabled = {depositDisabled}
            visible ={depositVisible}
            onClose ={onDepositClose}

          />

          <Withdraw 
          disabled = {withdrawDisabled}
          visible ={withdrawVisible}
          onClose ={onWithdrawClose} 
      
          />

          <Transfer
            disabled = {transferDisabled}
            visible ={transferVisible}
            onClose ={onTransferClose}
          />

          <Statements
            disabled = {statementsDisabled}
            visible ={statementsVisible}
            onClose ={onStatementsClose}
          />

          <Profile
            disabled = {profileDisabled}
            visible ={profileVisible}
            onClose ={onProfileClose}
        />
        </div>

        <footer>
          Created by Connor Logan 2022
        </footer>
      </div>
  );
}

export default App;
