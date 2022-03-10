using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Deino Species to store common natural stats of all Deinos
	#region SpeciesDeino
	public class SpeciesDeino : PokemonSpecies
	{
#nullable enable
		private static SpeciesDeino? _instance = null;
#nullable restore
        public static SpeciesDeino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDeino();
                }
                return _instance;
            }
        }

		#region SpeciesDeino Constructor
		public SpeciesDeino() : base(
			"Deino",
			0.8,
			17.3,
			52, // HPs
			65, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			38		
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
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Bite",
				"Roar",
				"Strength",
				"Dragon-Rage",
				"Thunder-Wave",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Shock-Wave",
				"Assurance",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Head-Smash",
				"Double-Hit",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Work-Up",
				"Belch",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Deino PokemonInstance Class
	#region Deino
	public class DeinoInstance : PokemonInstance
	{
		#region Deino Constructors
		/// <summary>
		/// Deino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DeinoInstance(string nickname, int level)
		: base(
				633,
				SpeciesDeino.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Builder only waiting for a Level
		/// </summary>
		public DeinoInstance(int level)
		: base(
				633,
				SpeciesDeino.Instance, // PokemonInstance Species
				"Deino", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Deino() : base(
			633,
			SpeciesDeino.Instance, // PokemonInstance Species
			Dark.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}