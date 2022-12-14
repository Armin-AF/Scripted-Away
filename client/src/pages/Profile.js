import Footer from "../components/Footer/Footer";
import {useAuth0} from "@auth0/auth0-react";
import Loading from "../components/Loading";
import LogOut from "../components/LogOut";

const Profile = () => {

  const {user, isAuthenticated, isLoading } = useAuth0();

  return (
    isAuthenticated && (
      <>
        {isLoading ? <div><Loading/></div> :

          <div className="bg-white my-40 w-96 h-96 pt-6 mx-auto space-y-5 flex flex-col items-center rounded overflow-hidden shadow-lg ">
              <span className="relative inline-block border-2 border-green-500 rounded-full" aria-label="avatar">
                  <img src={user.picture} alt="" className="w-30 h-30 rounded-full" />
                  <span className="absolute top-0 right-2 w-4 h-4 rounded-full bg-green-500 ring-2 ring-gray-50" />
                  <span className="absolute top-0 right-2 w-4 h-4 rounded-full bg-green-500 animate-ping" />
              </span>
              <h5 className="text-xl text-gray-500 dark:text-darkgray-400 font-bold">{user.given_name} {user.family_name}</h5>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">{user.email}</span>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">Username: {user.nickname}</span>
              <span className="text-sm text-gray-500 dark:text-darkgray-400">Language: {user.locale}</span>
              <LogOut/>

          </div>}

        <Footer/>
      </>
    )
  );
};

export default Profile;
