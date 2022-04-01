import * as React from "react";
import { Routes, Route, Link } from "react-router-dom";
import Contacts from "./pages/Contacts";
import Home from "./pages/Home";

function App() {
  return (
    <Routes>
    <Route path="/" element={<Home />} />
    <Route path="/contacts" element={<Contacts />} />
  </Routes>
  );
}

export default App;