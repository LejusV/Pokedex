using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Numel Species to store common natural stats of all Numels
	#region NumelSpecies
	public class NumelSpecies : PokemonSpecies
	{
#nullable enable
		private static NumelSpecies? _instance = null;
#nullable restore
        public static NumelSpecies Instance => _instance ?? (_instance = new NumelSpecies());

		#region NumelSpecies Constructor
		public NumelSpecies() : base(
			322,
			"Numel",
			Fire.Instance, Ground.Instance,
			0.7,
			24.0,
			new PokemonStats(
				60, // HPs
				60, 40, // Attack & Defense
				65, 45, // Spacial Attack & Defense
				35 // Speed
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
				"Stomp",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Ember",
				"Flamethrower",
				"Strength",
				"Growth",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Yawn",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Howl",
				"Natural-Gift",
				"Earth-Power",
				"Mud-Bomb",
				"Lava-Plume",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Flame-Burst",
				"Heavy-Slam",
				"Flame-Charge",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}