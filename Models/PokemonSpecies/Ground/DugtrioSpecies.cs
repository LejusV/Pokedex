using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dugtrio Species to store common natural stats of all Dugtrios
	#region DugtrioSpecies
	public class DugtrioSpecies : PokemonSpecies
	{
#nullable enable
		private static DugtrioSpecies? _instance = null;
#nullable restore
        public static DugtrioSpecies Instance => _instance ?? (_instance = new DugtrioSpecies());

		#region DugtrioSpecies Constructor
		public DugtrioSpecies() : base(
			51,
			"Dugtrio",
			Ground.Instance,
			0.7,
			33.3,
			new PokemonStats(
				35, // HPs
				100, 50, // Attack & Defense
				50, 70, // Spacial Attack & Defense
				120 // Speed
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
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Natural-Gift",
				"Sucker-Punch",
				"Night-Slash",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}