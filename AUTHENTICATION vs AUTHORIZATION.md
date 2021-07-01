
# Authentication vs Authorization

* [Authentication](#authentication)
    * [Knowledge based authentication](#knowledge-based-authentication)
	* [Possession based authentication](#possession-based-authentication)
	* [Multi Factor authentication](#multi-factor-authentication)
* [Authorization](#authorization)
* [Principal](#principal)

# Authentication
- Its used to confirm who are you.
- Usually contains one ID that represents the person trying to login.

## Knowledge based authentication 
- User provides user and password.
- [Advantage] Easy to implement and use
- [Disadvantage] Easy to access if someone discover your data.

## Possesion based authentication 
- Use some tool or device that the user has possesion Phone/Text Messages.
	- Phone and Text Messages
	- Token or Key Cards

## Multi Factor Authentication
- Its the combination of Knowledge and Possesion approaches.

# Authorization
- It's used to define what an user can do.
- It can be defining roles (READONLY, SUPERUSER, ADMIN, etc)

# Principal
- Its the current logged user.
- So the app keeps the principal or logged user on memory.
