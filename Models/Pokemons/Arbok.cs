using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Arbok Species to store common natural stats of all Arboks
	#region SpeciesArbok
	public class SpeciesArbok : PokemonSpecies
	{
#nullable enable
		private static SpeciesArbok? _instance = null;
#nullable restore
        public static SpeciesArbok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArbok();
                }
                return _instance;
            }
        }

		#region SpeciesArbok Constructor
		public SpeciesArbok() : base(
			24,
			"Arbok",
			3.5,
			65.0,
			60, // HPs
			95, 69, // Attack & Defense
			65, 79, // Special Attack & Defense
			80		
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
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Bite",
				"Acid",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Haze",
				"Bide",
				"Skull-Bash",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Natural-Gift",
				"Payback",
				"Gastro-Acid",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"Seed-Bomb",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Acid-Spray",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Belch",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Arbok PokemonInstance Class
	#region Arbok
	public class ArbokInstance : PokemonInstance
	{
		#region Arbok Constructors
		/// <summary>
		/// Arbok Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArbokInstance(string nickname, int level)
		: base(
				SpeciesArbok.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Builder only waiting for a Level
		/// </summary>
		public ArbokInstance(int level)
		: base(
				SpeciesArbok.Instance, // PokemonInstance Species
				"Arbok", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArbokInstance() : base(
			SpeciesArbok.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}