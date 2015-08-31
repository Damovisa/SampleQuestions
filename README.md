# SampleQuestions Demo Application presented at DDD Melbourne - 8 August 2015

Each commit represents a stage of the demo:

 * Empty Console Application
 * Hello World using Self-hosted OWIN and NancyFX
 * Hello World returned in an object - content negotiation will allow that object to be returned as XML or JSON depending on the `Accept` header in the request
 * The Sample Questions API - Get a single sample question or a random set of 10.
 * Adding HATEOAS-style links to the returned objects
 * Building a basic web site that uses the API
