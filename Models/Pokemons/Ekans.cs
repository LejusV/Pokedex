using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ekans Species to store common natural stats of all Ekanss
	#region SpeciesEkans
	public class SpeciesEkans : PokemonSpecies
	{
#nullable enable
		private static SpeciesEkans? _instance = null;
#nullable restore
        public static SpeciesEkans Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEkans();
                }
                return _instance;
            }
        }

		#region SpeciesEkans Constructor
		public SpeciesEkans() : base(
			23,
			"Ekans",
			2.0,
			6.9,
			35, // HPs
			60, 44, // Attack & Defense
			40, 54, // Special Attack & Defense
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
				"Bind",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Bite",
				"Disable",
				"Acid",
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
				"Scary-Face",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Beat-Up",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Rock-Tomb",
				"Poison-Tail",
				"Natural-Gift",
				"Payback",
				"Gastro-Acid",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Aqua-Tail",
				"Seed-Bomb",
				"Switcheroo",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Coil",
				"Acid-Spray",
				"Round",
				"Bulldoze",
				"Belch",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Ekans PokemonInstance Class
	#region Ekans
	public class EkansInstance : PokemonInstance
	{
		#region Ekans Constructors
		/// <summary>
		/// Ekans Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EkansInstance(string nickname, int level)
		: base(
				SpeciesEkans.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Builder only waiting for a Level
		/// </summary>
		public EkansInstance(int level)
		: base(
				SpeciesEkans.Instance, // PokemonInstance Species
				"Ekans", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ekans Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public EkansInstance() : base(
			SpeciesEkans.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}