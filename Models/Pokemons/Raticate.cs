using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Raticate Species to store common natural stats of all Raticates
	#region SpeciesRaticate
	public class SpeciesRaticate : PokemonSpecies
	{
#nullable enable
		private static SpeciesRaticate? _instance = null;
#nullable restore
        public static SpeciesRaticate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRaticate();
                }
                return _instance;
            }
        }

		#region SpeciesRaticate Constructor
		public SpeciesRaticate() : base(
			20,
			"Raticate",
			0.7,
			18.5,
			55, // HPs
			81, 60, // Attack & Defense
			50, 70, // Special Attack & Defense
			97		
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
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
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"U-Turn",
				"Assurance",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Raticate PokemonInstance Class
	#region Raticate
	public class RaticateInstance : PokemonInstance
	{
		#region Raticate Constructors
		/// <summary>
		/// Raticate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RaticateInstance(string nickname, int level)
		: base(
				SpeciesRaticate.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Builder only waiting for a Level
		/// </summary>
		public RaticateInstance(int level)
		: base(
				SpeciesRaticate.Instance, // PokemonInstance Species
				"Raticate", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raticate Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RaticateInstance() : base(
			SpeciesRaticate.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}