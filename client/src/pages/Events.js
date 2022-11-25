import React,{useState, useEffect} from "react";
import { useAuth0 } from "@auth0/auth0-react";
import Footer from "../components/Footer/Footer";
import SearchBar from "../components/Search";
import CardList from "../components/CardList";
import brandname from "../assets/BrandName_Only.png";

const Events = () => {
    const { user, isAuthenticated,getAccessTokenSilently, isLoading } = useAuth0();
    const [userMetadata, setUserMetadata] = useState(null);
    const [posts, setPosts] = useState([])
    const [searchResults, setSearchResults] = useState([])

    useEffect(() => {
        const getUserMetadata = async () => {

            try {
                const accessToken = await getAccessTokenSilently({
                    audience: `https://lingofikaapi.azurewebsites.net`,
                });
                console.log(accessToken + "accessToken")

                const userDetailsByIdUrl = `https://lingofikaapi.azurewebsites.net/api/User`;

                const metadataResponse = await fetch(userDetailsByIdUrl, {
                    headers: {
                        Authorization: `Bearer ${accessToken}`,
                    },
                });

                const { user_metadata } = await metadataResponse.json().then(j => {
                    console.log(j)
                    setUserMetadata(j)
                });
                console.log(user_metadata)
            } catch (e) {
                console.log(e.message);
            }
        };

        getUserMetadata()
            .then(r => console.log(r));
    }, [getAccessTokenSilently, user?.sub]);

    useEffect(() => {
        fetch('https://lingofikaapi.azurewebsites.net/api/Meeting')
            .then(response => response.json())
            .then(data => {setPosts(data)
                setSearchResults(data)})}, [])


    if (isLoading) {
        return <div>Loading ...</div>;
    }

    const usersApi = JSON.stringify(userMetadata)
    console.log(usersApi)

    return (
        isAuthenticated && (
            <div>
                {/* <h1 className="font-medium leading-tight text-6xl mb-2 text-blue-900 mt-10">Languini</h1> */}
                <h3 className="font-medium text-2xl mt-10">Find Events</h3>
                <SearchBar posts={posts} setSearchResults={setSearchResults} />
                <CardList searchResults={searchResults} />
                <Footer />

            </div>
        )
    );
};


export default Events;
