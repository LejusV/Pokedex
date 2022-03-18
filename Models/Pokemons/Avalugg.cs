using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Avalugg Species to store common natural stats of all Avaluggs
	#region SpeciesAvalugg
	public class SpeciesAvalugg : PokemonSpecies
	{
#nullable enable
		private static SpeciesAvalugg? _instance = null;
#nullable restore
        public static SpeciesAvalugg Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAvalugg();
                }
                return _instance;
            }
        }

		#region SpeciesAvalugg Constructor
		public SpeciesAvalugg() : base(
			713,
			"Avalugg",
			2.0,
			505.0,
			95, // HPs
			117, 184, // Attack & Defense
			44, 46, // Special Attack & Defense
			28		
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Recover",
				"Harden",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Ice-Ball",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Water-Pulse",
				"Gyro-Ball",
				"Rock-Polish",
				"Giga-Impact",
				"Avalanche",
				"Ice-Fang",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Wide-Guard",
				"After-You",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Avalugg PokemonInstance Class
	#region Avalugg
	public class AvaluggInstance : PokemonInstance
	{
		#region Avalugg Constructors
		/// <summary>
		/// Avalugg Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AvaluggInstance(string nickname, int level)
		: base(
				SpeciesAvalugg.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Builder only waiting for a Level
		/// </summary>
		public AvaluggInstance(int level)
		: base(
				SpeciesAvalugg.Instance, // PokemonInstance Species
				"Avalugg", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AvaluggInstance() : base(
			SpeciesAvalugg.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}