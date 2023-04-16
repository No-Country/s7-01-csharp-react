import React, { useEffect } from "react";
import Logo from "../../assets/images/Logo.svg";
import profilePic from "../../assets/images/profilePic.png";
import { getAllUsers } from "../../services/getAllUsers";

const Navbar = () => {
  useEffect(() => {
    getUser();
  }, []);
  const getUser = async() =>{
    try {
      const res = await getAllUsers();
      console.log(res);
    } catch (error) {
      console.log(error);
    }

  }
 
  return (
    <nav className="mx-auto flex justify-between w-full ">
      <div className="text-2xl cursor-pointer">
        <img src={Logo} alt="Logo" className="w-[130px] h-[32] mt-2 ml-2 " />
      </div>
      <div className="cursor-pointer">
        <img
          src={profilePic}
          alt="profilePic"
          className="w-8 h-8 rounded-full mt-2 mr-2"
        />
      </div>
    </nav>
  );
};

export default Navbar;
