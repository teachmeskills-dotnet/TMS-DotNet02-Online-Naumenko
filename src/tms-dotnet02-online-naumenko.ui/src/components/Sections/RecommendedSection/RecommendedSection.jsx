import React, {useState} from 'react';
import bgimage from '../../Posts/avatar.jpeg';
import PostAuthorOpinion from '../../Posts/PostAuthorOpinion/PostAuthorOpinion';
import PostsData from '../MainSection/PostsData';
import { useNavigate } from 'react-router-dom';

const RecommendedSection = (props) => {
    const [posts, setPosts] = useState([]);

    const getPosts = (posts) => {
        setPosts(posts);
    }
    const router = useNavigate();
    
    return (
        <section className="section-main pt__3">
            <PostsData posts={getPosts} getAll={true}/>
            <div className="row g__3">
                {posts.slice(2, 6).map(element => 
                    <div className="col-xl-6">
                        <PostAuthorOpinion 
                                handleToggle={props.handleToggle} 
                                link={() => router(`/${element.date}/${element.slug}/${element.id}`)}
                                title={element.title} 
                                date={"2022-04-19T00:00:00"} 
                                views={14} 
                                background={element.file.path}
                                height='sm'
                                authorLink='https://author.ru'
                                authorName='Дмитрий Науменко'/>
                    </div>
                )}
            </div>
        </section>
    );
};

export default RecommendedSection;