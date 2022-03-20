using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Carracosta Species to store common natural stats of all Carracostas
	#region CarracostaSpecies
	public class CarracostaSpecies : PokemonSpecies
	{
#nullable enable
		private static CarracostaSpecies? _instance = null;
#nullable restore
        public static CarracostaSpecies Instance => _instance ?? (_instance = new CarracostaSpecies());

		#region CarracostaSpecies Constructor
		public CarracostaSpecies() : base(
			565,
			"Carracosta",
			Water.Instance, Rock.Instance,
			1.2,
			81.0,
			new PokemonStats(
				74, // HPs
				108, 133, // Attack & Defense
				83, 65, // Spacial Attack & Defense
				32 // Speed
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
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Withdraw",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Brine",
				"Rock-Polish",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Aqua-Jet",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}