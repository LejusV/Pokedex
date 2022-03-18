using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shuppet Species to store common natural stats of all Shuppets
	#region SpeciesShuppet
	public class SpeciesShuppet : PokemonSpecies
	{
#nullable enable
		private static SpeciesShuppet? _instance = null;
#nullable restore
        public static SpeciesShuppet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShuppet();
                }
                return _instance;
            }
        }

		#region SpeciesShuppet Constructor
		public SpeciesShuppet() : base(
			353,
			"Shuppet",
			0.6,
			2.3,
			44, // HPs
			75, 35, // Attack & Defense
			63, 33, // Special Attack & Defense
			45		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Foresight",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Shadow-Sneak",
				"Trick-Room",
				"Gunk-Shot",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Hex",
				"Phantom-Force",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Shuppet PokemonInstance Class
	#region Shuppet
	public class ShuppetInstance : PokemonInstance
	{
		#region Shuppet Constructors
		/// <summary>
		/// Shuppet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShuppetInstance(string nickname, int level)
		: base(
				SpeciesShuppet.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Builder only waiting for a Level
		/// </summary>
		public ShuppetInstance(int level)
		: base(
				SpeciesShuppet.Instance, // PokemonInstance Species
				"Shuppet", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shuppet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ShuppetInstance() : base(
			SpeciesShuppet.Instance, // PokemonInstance Species
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}