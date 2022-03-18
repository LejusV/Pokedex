using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Victreebel Species to store common natural stats of all Victreebels
	#region SpeciesVictreebel
	public class SpeciesVictreebel : PokemonSpecies
	{
#nullable enable
		private static SpeciesVictreebel? _instance = null;
#nullable restore
        public static SpeciesVictreebel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVictreebel();
                }
                return _instance;
            }
        }

		#region SpeciesVictreebel Constructor
		public SpeciesVictreebel() : base(
			71,
			"Victreebel",
			1.7,
			15.5,
			80, // HPs
			105, 65, // Attack & Defense
			100, 70, // Special Attack & Defense
			70		
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
				"Cut",
				"Bind",
				"Vine-Whip",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Mega-Drain",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Nature-Power",
				"Knock-Off",
				"Secret-Power",
				"Bullet-Seed",
				"Leaf-Blade",
				"Natural-Gift",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Leaf-Storm",
				"Captivate",
				"Grass-Knot",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Leaf-Tornado",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Victreebel PokemonInstance Class
	#region Victreebel
	public class VictreebelInstance : PokemonInstance
	{
		#region Victreebel Constructors
		/// <summary>
		/// Victreebel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VictreebelInstance(string nickname, int level)
		: base(
				SpeciesVictreebel.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Builder only waiting for a Level
		/// </summary>
		public VictreebelInstance(int level)
		: base(
				SpeciesVictreebel.Instance, // PokemonInstance Species
				"Victreebel", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public VictreebelInstance() : base(
			SpeciesVictreebel.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}