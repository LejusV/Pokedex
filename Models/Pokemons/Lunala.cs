using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lunala Species to store common natural stats of all Lunalas
	#region SpeciesLunala
	public class SpeciesLunala : PokemonSpecies
	{
#nullable enable
		private static SpeciesLunala? _instance = null;
#nullable restore
        public static SpeciesLunala Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLunala();
                }
                return _instance;
            }
        }

		#region SpeciesLunala Constructor
		public SpeciesLunala() : base(
			792,
			"Lunala",
			4.0,
			120.0,
			137, // HPs
			113, 89, // Attack & Defense
			137, 107, // Special Attack & Defense
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
				"Fly",
				"Roar",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Night-Shade",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Substitute",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Magic-Coat",
				"Cosmic-Power",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Air-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Charge-Beam",
				"Wide-Guard",
				"Psyshock",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Work-Up",
				"Night-Daze",
				"Phantom-Force",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Moongeist-Beam"
			};
		}
		#endregion
	}
	#endregion

	//Lunala PokemonInstance Class
	#region Lunala
	public class LunalaInstance : PokemonInstance
	{
		#region Lunala Constructors
		/// <summary>
		/// Lunala Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LunalaInstance(string nickname, int level)
		: base(
				SpeciesLunala.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Builder only waiting for a Level
		/// </summary>
		public LunalaInstance(int level)
		: base(
				SpeciesLunala.Instance, // PokemonInstance Species
				"Lunala", level,
				Psychic.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LunalaInstance() : base(
			SpeciesLunala.Instance, // PokemonInstance Species
			Psychic.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}