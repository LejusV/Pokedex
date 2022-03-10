using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Durant Species to store common natural stats of all Durants
	#region SpeciesDurant
	public class SpeciesDurant : PokemonSpecies
	{
#nullable enable
		private static SpeciesDurant? _instance = null;
#nullable restore
        public static SpeciesDurant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDurant();
                }
                return _instance;
            }
        }

		#region SpeciesDurant Constructor
		public SpeciesDurant() : base(
			"Durant",
			0.3,
			33.0,
			58, // HPs
			109, 112, // Attack & Defense
			48, 48, // Special Attack & Defense
			109		
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
				"Vice-Grip",
				"Guillotine",
				"Cut",
				"Sand-Attack",
				"Bite",
				"Strength",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Metal-Claw",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Rock-Polish",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Bug-Bite",
				"Hone-Claws",
				"Entrainment",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Durant PokemonInstance Class
	#region Durant
	public class DurantInstance : PokemonInstance
	{
		#region Durant Constructors
		/// <summary>
		/// Durant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DurantInstance(string nickname, int level)
		: base(
				632,
				SpeciesDurant.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Builder only waiting for a Level
		/// </summary>
		public DurantInstance(int level)
		: base(
				632,
				SpeciesDurant.Instance, // PokemonInstance Species
				"Durant", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Durant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Durant() : base(
			632,
			SpeciesDurant.Instance, // PokemonInstance Species
			Bug.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}