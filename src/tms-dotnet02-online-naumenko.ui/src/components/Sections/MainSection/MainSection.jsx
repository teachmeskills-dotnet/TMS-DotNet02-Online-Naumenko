import React, {useState, useEffect} from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import { useNavigate } from "react-router-dom";

const MainSection = (props) => {

    // //const [items[0], setitems[0]] = useState('');
    // var items[0];
    const [error, setError] = useState(null);
    const [isLoaded, setIsLoaded] = useState(false);
    const [items, setItems] = useState([]);

    const router = useNavigate();
    
    const url = 'https://localhost:5001/posts';

    useEffect(() => {
        // GET request using axios inside useEffect React hook
        axios.get(url)
            .then(response => setTotalReactPackages(response.data.total));
    
    // empty dependency array means this effect will only run once (like componentDidMount in classes)
    }, []);

    // useEffect(() => {
    //     fetch(url)
    //       .then(res => res.json())
    //       .then(
    //         (result) => {
    //           setIsLoaded(true);
    //           setItems(result);
    //           console.log(result);
    //         },
    //         // Примечание: важно обрабатывать ошибки именно здесь, а не в блоке catch(),
    //         // чтобы не перехватывать исключения из ошибок в самих компонентах.
    //         (error) => {
    //           setIsLoaded(true);
    //           setError(error);
    //         }
    //       )
    //   }, [])

    // const fetchData = async () => {
    //     try {
    //       const response = await fetch(url, {
    //         method: 'GET'});
    //       const json = await response.json();
    //       items[0] = json[0];
    //     } catch (error) {
    //       console.log("error", error);
    //     }
    //   };
    //   fetchData();
    console.log(items);
    const handleTogglePost = () => {
        router(`/posts/${items[0].slug}`)
      };

    if (error) {
        return <div>Ошибка: {error.message}</div>;
    } else if (!isLoaded) {
        return <div>Загрузка...</div>;
    } else {
        return (
            <section className="section-main pt__3">
                <div className="row g__3">
                    <div className="col-md-6 col-lg-5 col-xl-5">
                        <PostWithBackgroud 
                        handleToggle={props.handleToggle} 
                        link={() => router(`/${items[0].date}/${items[0].slug}`)} 
                        title={items[0].title} 
                        date={items[0].date} 
                        views={10} 
                        background={bgimage}
                        height='lg'/>
                    </div>
                    <div className="col-md-6 col-lg-4 col-xl-3">
                        <PostList 
                        sectionName={props.sectionName}
                        handleToggle={props.handleToggle} 
                        posts={props.posts}/>
                    </div>
                    <div className="col-md-12 col-lg-3 col-xl-4">
                        <div className="row g__3">
                            <div className="col-md-6 col-lg-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={'https://items[0].items[0]'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'/>
                            </div>
                            <div className="col-md-6 col-lg-12">
                                <PostWithBackgroud 
                                handleToggle={props.handleToggle} 
                                link={'https://items[0].items[0]'} 
                                title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                                date={'Вчера, 21:34'} 
                                views={10} 
                                background={bgimage}
                                height='sm'/>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        );
    }
};

export default MainSection;