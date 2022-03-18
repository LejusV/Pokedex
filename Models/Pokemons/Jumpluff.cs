using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jumpluff Species to store common natural stats of all Jumpluffs
	#region SpeciesJumpluff
	public class SpeciesJumpluff : PokemonSpecies
	{
#nullable enable
		private static SpeciesJumpluff? _instance = null;
#nullable restore
        public static SpeciesJumpluff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJumpluff();
                }
                return _instance;
            }
        }

		#region SpeciesJumpluff Constructor
		public SpeciesJumpluff() : base(
			189,
			"Jumpluff",
			0.8,
			3.0,
			75, // HPs
			55, 70, // Attack & Defense
			55, 95, // Special Attack & Defense
			110		
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
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Double-Edge",
				"Tail-Whip",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Memento",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Silver-Wind",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Natural-Gift",
				"U-Turn",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Rage-Powder",
				"Round",
				"Acrobatics",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Jumpluff PokemonInstance Class
	#region Jumpluff
	public class JumpluffInstance : PokemonInstance
	{
		#region Jumpluff Constructors
		/// <summary>
		/// Jumpluff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JumpluffInstance(string nickname, int level)
		: base(
				SpeciesJumpluff.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Builder only waiting for a Level
		/// </summary>
		public JumpluffInstance(int level)
		: base(
				SpeciesJumpluff.Instance, // PokemonInstance Species
				"Jumpluff", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jumpluff Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public JumpluffInstance() : base(
			SpeciesJumpluff.Instance, // PokemonInstance Species
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}