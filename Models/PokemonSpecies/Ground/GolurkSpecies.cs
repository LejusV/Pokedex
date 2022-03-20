using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golurk Species to store common natural stats of all Golurks
	#region GolurkSpecies
	public class GolurkSpecies : PokemonSpecies
	{
#nullable enable
		private static GolurkSpecies? _instance = null;
#nullable restore
        public static GolurkSpecies Instance => _instance ?? (_instance = new GolurkSpecies());

		#region GolurkSpecies Constructor
		public GolurkSpecies() : base(
			623,
			"Golurk",
			Ground.Instance, Ghost.Instance,
			2.8,
			330.0,
			new PokemonStats(
				89, // HPs
				124, 80, // Attack & Defense
				55, 80, // Spacial Attack & Defense
				55 // Speed
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Fly",
				"Ice-Beam",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Defense-Curl",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Magnitude",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Magic-Coat",
				"Brick-Break",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Signal-Beam",
				"Shadow-Punch",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Gyro-Ball",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Telekinesis",
				"Heavy-Slam",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Phantom-Force",
				"Confide",
				"Power-Up-Punch",
				"High-Horsepower",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}