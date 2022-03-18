using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dedenne Species to store common natural stats of all Dedennes
	#region SpeciesDedenne
	public class SpeciesDedenne : PokemonSpecies
	{
#nullable enable
		private static SpeciesDedenne? _instance = null;
#nullable restore
        public static SpeciesDedenne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDedenne();
                }
                return _instance;
            }
        }

		#region SpeciesDedenne Constructor
		public SpeciesDedenne() : base(
			702,
			"Dedenne",
			0.2,
			2.2,
			67, // HPs
			58, 57, // Attack & Defense
			81, 67, // Special Attack & Defense
			101		
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
				"Thunder-Punch",
				"Cut",
				"Tackle",
				"Tail-Whip",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Double-Team",
				"Flash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Charge",
				"Helping-Hand",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Entrainment",
				"Round",
				"Retaliate",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Parabolic-Charge",
				"Play-Rough",
				"Confide",
				"Eerie-Impulse",
				"Nuzzle",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion

	//Dedenne PokemonInstance Class
	#region Dedenne
	public class DedenneInstance : PokemonInstance
	{
		#region Dedenne Constructors
		/// <summary>
		/// Dedenne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DedenneInstance(string nickname, int level)
		: base(
				SpeciesDedenne.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Builder only waiting for a Level
		/// </summary>
		public DedenneInstance(int level)
		: base(
				SpeciesDedenne.Instance, // PokemonInstance Species
				"Dedenne", level,
				Electric.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dedenne Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DedenneInstance() : base(
			SpeciesDedenne.Instance, // PokemonInstance Species
			Electric.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}