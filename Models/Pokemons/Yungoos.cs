using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yungoos Species to store common natural stats of all Yungooss
	#region SpeciesYungoos
	public class SpeciesYungoos : PokemonSpecies
	{
#nullable enable
		private static SpeciesYungoos? _instance = null;
#nullable restore
        public static SpeciesYungoos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYungoos();
                }
                return _instance;
            }
        }

		#region SpeciesYungoos Constructor
		public SpeciesYungoos() : base(
			734,
			"Yungoos",
			0.4,
			6.0,
			48, // HPs
			70, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
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
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Thrash",
				"Leer",
				"Bite",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Crunch",
				"Torment",
				"Facade",
				"Taunt",
				"Revenge",
				"Yawn",
				"Odor-Sleuth",
				"Rock-Tomb",
				"U-Turn",
				"Payback",
				"Last-Resort",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Yungoos PokemonInstance Class
	#region Yungoos
	public class YungoosInstance : PokemonInstance
	{
		#region Yungoos Constructors
		/// <summary>
		/// Yungoos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YungoosInstance(string nickname, int level)
		: base(
				SpeciesYungoos.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Builder only waiting for a Level
		/// </summary>
		public YungoosInstance(int level)
		: base(
				SpeciesYungoos.Instance, // PokemonInstance Species
				"Yungoos", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yungoos Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public YungoosInstance() : base(
			SpeciesYungoos.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}