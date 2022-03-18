using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Poipole Species to store common natural stats of all Poipoles
	#region SpeciesPoipole
	public class SpeciesPoipole : PokemonSpecies
	{
#nullable enable
		private static SpeciesPoipole? _instance = null;
#nullable restore
        public static SpeciesPoipole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPoipole();
                }
                return _instance;
            }
        }

		#region SpeciesPoipole Constructor
		public SpeciesPoipole() : base(
			803,
			"Poipole",
			0.6,
			1.8,
			67, // HPs
			73, 67, // Attack & Defense
			73, 67, // Special Attack & Defense
			73		
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
				"Fury-Attack",
				"Growl",
				"Acid",
				"Peck",
				"Toxic",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Charm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Helping-Hand",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion

	//Poipole PokemonInstance Class
	#region Poipole
	public class PoipoleInstance : PokemonInstance
	{
		#region Poipole Constructors
		/// <summary>
		/// Poipole Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PoipoleInstance(string nickname, int level)
		: base(
				SpeciesPoipole.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Builder only waiting for a Level
		/// </summary>
		public PoipoleInstance(int level)
		: base(
				SpeciesPoipole.Instance, // PokemonInstance Species
				"Poipole", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Poipole Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PoipoleInstance() : base(
			SpeciesPoipole.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}