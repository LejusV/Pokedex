using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Golurk Species to store common natural stats of all Golurks
	#region SpeciesGolurk
	public class SpeciesGolurk : PokemonSpecies
	{
#nullable enable
		private static SpeciesGolurk? _instance = null;
#nullable restore
        public static SpeciesGolurk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGolurk();
                }
                return _instance;
            }
        }

		#region SpeciesGolurk Constructor
		public SpeciesGolurk() : base(
			623,
			"Golurk",
			2.8,
			330.0,
			89, // HPs
			124, 80, // Attack & Defense
			55, 80, // Special Attack & Defense
			55		
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

	//Golurk PokemonInstance Class
	#region Golurk
	public class GolurkInstance : PokemonInstance
	{
		#region Golurk Constructors
		/// <summary>
		/// Golurk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GolurkInstance(string nickname, int level)
		: base(
				SpeciesGolurk.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Builder only waiting for a Level
		/// </summary>
		public GolurkInstance(int level)
		: base(
				SpeciesGolurk.Instance, // PokemonInstance Species
				"Golurk", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golurk Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GolurkInstance() : base(
			SpeciesGolurk.Instance, // PokemonInstance Species
			Ground.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}