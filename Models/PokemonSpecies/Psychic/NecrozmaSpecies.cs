using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Necrozma Species to store common natural stats of all Necrozmas
	#region NecrozmaSpecies
	public class NecrozmaSpecies : PokemonSpecies
	{
#nullable enable
		private static NecrozmaSpecies? _instance = null;
#nullable restore
        public static NecrozmaSpecies Instance => _instance ?? (_instance = new NecrozmaSpecies());

		#region NecrozmaSpecies Constructor
		public NecrozmaSpecies() : base(
			800,
			"Necrozma",
			Psychic.Instance,
			2.4,
			230.0,
			new PokemonStats(
				97, // HPs
				107, 101, // Attack & Defense
				127, 89, // Spacial Attack & Defense
				79 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Morning-Sun",
				"Moonlight",
				"Hidden-Power",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Rock-Blast",
				"Gravity",
				"Gyro-Ball",
				"Embargo",
				"Fling",
				"Wring-Out",
				"Rock-Polish",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Power-Gem",
				"Giga-Impact",
				"Shadow-Claw",
				"Psycho-Cut",
				"Mirror-Shot",
				"Flash-Cannon",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Psyshock",
				"Autotomize",
				"Round",
				"Stored-Power",
				"Bulldoze",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing",
				"Prismatic-Laser",
				"Photon-Geyser"
			};
		}
		#endregion
	}
	#endregion
}