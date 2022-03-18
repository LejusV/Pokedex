using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Golett Species to store common natural stats of all Goletts
	#region SpeciesGolett
	public class SpeciesGolett : PokemonSpecies
	{
#nullable enable
		private static SpeciesGolett? _instance = null;
#nullable restore
        public static SpeciesGolett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGolett();
                }
                return _instance;
            }
        }

		#region SpeciesGolett Constructor
		public SpeciesGolett() : base(
			622,
			"Golett",
			1.0,
			92.0,
			59, // HPs
			74, 50, // Attack & Defense
			35, 50, // Special Attack & Defense
			35		
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
				"Ice-Beam",
				"Low-Kick",
				"Strength",
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
				"Stealth-Rock",
				"Grass-Knot",
				"Telekinesis",
				"Low-Sweep",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Golett PokemonInstance Class
	#region Golett
	public class GolettInstance : PokemonInstance
	{
		#region Golett Constructors
		/// <summary>
		/// Golett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GolettInstance(string nickname, int level)
		: base(
				SpeciesGolett.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Builder only waiting for a Level
		/// </summary>
		public GolettInstance(int level)
		: base(
				SpeciesGolett.Instance, // PokemonInstance Species
				"Golett", level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golett Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GolettInstance() : base(
			SpeciesGolett.Instance, // PokemonInstance Species
			Ground.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}