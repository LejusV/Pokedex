using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cradily Species to store common natural stats of all Cradilys
	#region SpeciesCradily
	public class SpeciesCradily : PokemonSpecies
	{
#nullable enable
		private static SpeciesCradily? _instance = null;
#nullable restore
        public static SpeciesCradily Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCradily();
                }
                return _instance;
            }
        }

		#region SpeciesCradily Constructor
		public SpeciesCradily() : base(
			346,
			"Cradily",
			1.5,
			60.4,
			86, // HPs
			81, 97, // Attack & Defense
			81, 107, // Special Attack & Defense
			43		
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Constrict",
				"Amnesia",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Bullet-Seed",
				"Block",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Cradily PokemonInstance Class
	#region Cradily
	public class CradilyInstance : PokemonInstance
	{
		#region Cradily Constructors
		/// <summary>
		/// Cradily Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CradilyInstance(string nickname, int level)
		: base(
				SpeciesCradily.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Builder only waiting for a Level
		/// </summary>
		public CradilyInstance(int level)
		: base(
				SpeciesCradily.Instance, // PokemonInstance Species
				"Cradily", level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cradily Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CradilyInstance() : base(
			SpeciesCradily.Instance, // PokemonInstance Species
			Rock.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}