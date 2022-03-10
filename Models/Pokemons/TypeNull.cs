using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Type-Null Species to store common natural stats of all Type-Nulls
	#region SpeciesType-Null
	public class SpeciesTypeNull : PokemonSpecies
	{
#nullable enable
		private static SpeciesTypeNull? _instance = null;
#nullable restore
        public static SpeciesTypeNull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTypeNull();
                }
                return _instance;
            }
        }

		#region SpeciesType-Null Constructor
		public SpeciesTypeNull() : base(
			"Type-Null",
			1.9,
			120.5,
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			59		
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
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Thunder-Wave",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Hail",
				"Facade",
				"Imprison",
				"Crush-Claw",
				"Metal-Sound",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Payback",
				"Heal-Block",
				"Punishment",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Iron-Head",
				"Double-Hit",
				"Flame-Charge",
				"Round",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Type-Null PokemonInstance Class
	#region Type-Null
	public class TypeNullInstance : PokemonInstance
	{
		#region Type-Null Constructors
		/// <summary>
		/// Type-Null Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TypeNullInstance(string nickname, int level)
		: base(
				772,
				SpeciesTypeNull.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Builder only waiting for a Level
		/// </summary>
		public TypeNullInstance(int level)
		: base(
				772,
				SpeciesTypeNull.Instance, // PokemonInstance Species
				"Type-Null", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Type-Null Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TypeNull() : base(
			772,
			SpeciesTypeNull.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}