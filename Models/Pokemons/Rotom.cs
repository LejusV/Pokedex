using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rotom Species to store common natural stats of all Rotoms
	#region SpeciesRotom
	public class SpeciesRotom : PokemonSpecies
	{
#nullable enable
		private static SpeciesRotom? _instance = null;
#nullable restore
        public static SpeciesRotom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRotom();
                }
                return _instance;
            }
        }

		#region SpeciesRotom Constructor
		public SpeciesRotom() : base(
			479,
			"Rotom",
			0.3,
			0.3,
			50, // HPs
			50, 77, // Attack & Defense
			95, 77, // Special Attack & Defense
			91		
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
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Will-O-Wisp",
				"Facade",
				"Charge",
				"Trick",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Sucker-Punch",
				"Dark-Pulse",
				"Discharge",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Electro-Ball",
				"Foul-Play",
				"Round",
				"Hex",
				"Volt-Switch",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Rotom PokemonInstance Class
	#region Rotom
	public class RotomInstance : PokemonInstance
	{
		#region Rotom Constructors
		/// <summary>
		/// Rotom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RotomInstance(string nickname, int level)
		: base(
				SpeciesRotom.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Builder only waiting for a Level
		/// </summary>
		public RotomInstance(int level)
		: base(
				SpeciesRotom.Instance, // PokemonInstance Species
				"Rotom", level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RotomInstance() : base(
			SpeciesRotom.Instance, // PokemonInstance Species
			Electric.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}