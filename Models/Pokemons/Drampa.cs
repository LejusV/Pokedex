using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Drampa Species to store common natural stats of all Drampas
	#region SpeciesDrampa
	public class SpeciesDrampa : PokemonSpecies
	{
#nullable enable
		private static SpeciesDrampa? _instance = null;
#nullable restore
        public static SpeciesDrampa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDrampa();
                }
                return _instance;
            }
        }

		#region SpeciesDrampa Constructor
		public SpeciesDrampa() : base(
			780,
			"Drampa",
			3.0,
			185.0,
			78, // HPs
			60, 85, // Attack & Defense
			135, 91, // Special Attack & Defense
			36		
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
				"Razor-Wind",
				"Fly",
				"Roar",
				"Flamethrower",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Outrage",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Hyper-Voice",
				"Extrasensory",
				"Dragon-Claw",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Fling",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Hurricane",
				"Snarl",
				"Play-Rough",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Drampa PokemonInstance Class
	#region Drampa
	public class DrampaInstance : PokemonInstance
	{
		#region Drampa Constructors
		/// <summary>
		/// Drampa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DrampaInstance(string nickname, int level)
		: base(
				SpeciesDrampa.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Builder only waiting for a Level
		/// </summary>
		public DrampaInstance(int level)
		: base(
				SpeciesDrampa.Instance, // PokemonInstance Species
				"Drampa", level,
				Normal.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drampa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DrampaInstance() : base(
			SpeciesDrampa.Instance, // PokemonInstance Species
			Normal.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}