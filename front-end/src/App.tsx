import * as React from 'react'
import './App.css';
import { useState } from 'react';
import Login from './login/login-form';

function App() {


  return (
      <div className="App">
        <header className="App-header">
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
          </a>
          <Login
          enabled={true}
          visible={true}
        />
        </header>
       
      </div>
  );
}

export default App;
