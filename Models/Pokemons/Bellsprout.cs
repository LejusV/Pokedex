using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Bellsprout Species to store common natural stats of all Bellsprouts
	#region SpeciesBellsprout
	public class SpeciesBellsprout : PokemonSpecies
	{
#nullable enable
		private static SpeciesBellsprout? _instance = null;
#nullable restore
        public static SpeciesBellsprout Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBellsprout();
                }
                return _instance;
            }
        }

		#region SpeciesBellsprout Constructor
		public SpeciesBellsprout() : base(
			"Bellsprout",
			0.7,
			4.0,
			50, // HPs
			75, 35, // Attack & Defense
			70, 30, // Special Attack & Defense
			40		
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
				"Slam",
				"Vine-Whip",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Growth",
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
				"Leech-Life",
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
				"Encore",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Weather-Ball",
				"Tickle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion

	//Bellsprout PokemonInstance Class
	#region Bellsprout
	public class BellsproutInstance : PokemonInstance
	{
		#region Bellsprout Constructors
		/// <summary>
		/// Bellsprout Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BellsproutInstance(string nickname, int level)
		: base(
				69,
				SpeciesBellsprout.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Builder only waiting for a Level
		/// </summary>
		public BellsproutInstance(int level)
		: base(
				69,
				SpeciesBellsprout.Instance, // PokemonInstance Species
				"Bellsprout", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Bellsprout() : base(
			69,
			SpeciesBellsprout.Instance, // PokemonInstance Species
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}