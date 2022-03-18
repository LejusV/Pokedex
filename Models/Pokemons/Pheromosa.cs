using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pheromosa Species to store common natural stats of all Pheromosas
	#region SpeciesPheromosa
	public class SpeciesPheromosa : PokemonSpecies
	{
#nullable enable
		private static SpeciesPheromosa? _instance = null;
#nullable restore
        public static SpeciesPheromosa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPheromosa();
                }
                return _instance;
            }
        }

		#region SpeciesPheromosa Constructor
		public SpeciesPheromosa() : base(
			795,
			"Pheromosa",
			1.8,
			25.0,
			71, // HPs
			137, 37, // Attack & Defense
			137, 37, // Special Attack & Defense
			151		
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
				"Stomp",
				"Double-Kick",
				"Jump-Kick",
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Toxic",
				"Agility",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Substitute",
				"Triple-Kick",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Silver-Wind",
				"Bounce",
				"Roost",
				"Feint",
				"U-Turn",
				"Fling",
				"Me-First",
				"Poison-Jab",
				"Bug-Buzz",
				"Focus-Blast",
				"Giga-Impact",
				"Quiver-Dance",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Quick-Guard",
				"Confide",
				"Lunge",
				"Speed-Swap"
			};
		}
		#endregion
	}
	#endregion

	//Pheromosa PokemonInstance Class
	#region Pheromosa
	public class PheromosaInstance : PokemonInstance
	{
		#region Pheromosa Constructors
		/// <summary>
		/// Pheromosa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PheromosaInstance(string nickname, int level)
		: base(
				SpeciesPheromosa.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Builder only waiting for a Level
		/// </summary>
		public PheromosaInstance(int level)
		: base(
				SpeciesPheromosa.Instance, // PokemonInstance Species
				"Pheromosa", level,
				Bug.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pheromosa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PheromosaInstance() : base(
			SpeciesPheromosa.Instance, // PokemonInstance Species
			Bug.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}