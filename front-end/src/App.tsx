import * as React from 'react'
import './App.css';
import { useState } from 'react';
import Login from './forms/login-form';
import Splash from './main/splash';

function App() {


  return (
      <div className="App">
        <div>
          <Splash></Splash>
        </div>

        <footer>
          Created by Connor Logan 2022
        </footer>
      </div>
  );
}

export default App;
