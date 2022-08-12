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

  const [depositDisabled, setDepositDisabled] = useState(false);
  const onShowDeposit = () => setDepositVisible(true);
  const onDepositClose = () => setDepositVisible(false);


  const onShowHome = () => { setHomeVisible(true)
    setSplashVisible(false)} ;

  const onLogout = () => { setHomeVisible(false)
    setSplashVisible(true)} ;


  
  const onLogin = (props:LogInDetails) =>{ 
      
    // client operations here
  }


  return (
      <div className="App">
        <div>

        <Navbar
        
        toggleDeposit={onShowDeposit}
        toggleDepositClose={onDepositClose}

        // FILL OUT THESE FUNCTIONS WITH FUNCTIONALITY
        // toggleWithdraw():void;
        // toggleTransfer():void;
        // toggleStatements():void;
        
        />
        <Home
          
        
        />

        <Deposit
          disabled = {depositDisabled}
          visible ={depositVisible}
          onClose ={onDepositClose}

        />

        <Withdraw 
         disabled = {depositDisabled}
         visible ={depositVisible}
         onClose ={onDepositClose} 
    
        />

        <Transfer
           disabled = {depositDisabled}
           visible ={depositVisible}
           onClose ={onDepositClose}
        />

        <Statements
           disabled = {depositDisabled}
           visible ={depositVisible}
           onClose ={onDepositClose}
        />


        </div>

        <footer>
          Created by Connor Logan 2022
        </footer>
      </div>
  );
}

export default App;
