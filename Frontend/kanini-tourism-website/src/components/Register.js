import './Register.css';
import { useNavigate } from "react-router-dom";
import {Link} from 'react-router-dom';
import React from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
const Register = () => {
    return (
        <div className="App">
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<section id="team" class="pb-5">
<h5 class="section-title h1">Register</h5>
    <div class="container">
        <div class="row">
           
           
            <div class="col-xs-12 col-sm-6 col-md-4">
                <div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                    <div class="mainflip">
                        <div class="frontside">
                            <div class="card">
                                <div class="card-body text-center">
                                    <h4 class="card-title">Travel Agent</h4>
                                    <p class="card-text">Travel Agent must register and upload tour information </p>
                                    <img class=" img-fluid" src="https://t4.ftcdn.net/jpg/02/29/53/11/360_F_229531197_jmFcViuzXaYOQdoOK1qyg7uIGdnuKhpt.jpg" alt="card image"/>
                                        <br/><br/>
                                    <a href="#" class="btn btn-primary btn-sm"><i class="fa fa-plus"></i></a>
                                </div>
                            </div>
                        </div>
                        <div class="backside">
                            <div class="card">
                                <div class="card-body text-center mt-4">
                                    <h4 class="card-title">Travel Agent</h4>
                                    <p class="card-text">Travel Agent must wait for admin approval and then can upload the tour information, the photos and spots near the location.</p>
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-facebook"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-twitter"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-skype"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-google"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                                {/* <button className="btn-success"><Link to="/#" className="btn-success">Proceed</Link></button> */}

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xs-12 col-sm-6 col-md-4">
                <div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                    <div class="mainflip">
                        <div class="frontside">
                            <div class="card">
                                <div class="card-body text-center">
                                    <h4 class="card-title">Traveller</h4>
                                    <p class="card-text">Traveller must perform both Login & Register process </p>
                                    <img class=" img-fluid" src="https://cdn.vectorstock.com/i/1000x1000/39/19/surgical-mask-icon-with-patient-person-profile-vector-32493919.webp" alt="card image"/>
                                        <br/><br/>
                                    <a href="#" class="btn btn-primary btn-sm"><i class="fa fa-plus"></i></a>
                                </div>
                            </div>
                        </div>
                        <div class="backside">
                            <div class="card">
                                <div class="card-body text-center mt-4">
                                    <h4 class="card-title">Patient</h4>
                                    <p class="card-text">A traveller can use the website to get information on the places where they like to visit, the complete cost of the tour and can generate a bill for the whole tour package</p>
                                    <ul class="list-inline">
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-facebook"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-twitter"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-skype"></i>
                                            </a>
                                        </li>
                                        <li class="list-inline-item">
                                            <a class="social-icon text-xs-center" target="_blank" href="#">
                                                <i class="fa fa-google"></i>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                                {/* <button  className="btn-success"><Link to="#" className="btn-success">Proceed</Link></button> */}
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </div>
</section>
</div>
    )
}
export default Register;