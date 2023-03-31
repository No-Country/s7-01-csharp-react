import React from "react";
import { Routes, Route } from "react-router-dom";

// components
import Home from "../pages/Home";
import { Clinic } from "../pages/Clinic";

export function AppRouter() {
  return (
    <>
      <Routes>
        <Route path="/home" element={<Home />} />
        <Route path="/clinic" element={<Clinic />} />
      </Routes>
    </>
  );
}
