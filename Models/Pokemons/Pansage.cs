using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pansage Species to store common natural stats of all Pansages
	#region SpeciesPansage
	public class SpeciesPansage : PokemonSpecies
	{
#nullable enable
		private static SpeciesPansage? _instance = null;
#nullable restore
        public static SpeciesPansage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPansage();
                }
                return _instance;
            }
        }

		#region SpeciesPansage Constructor
		public SpeciesPansage() : base(
			"Pansage",
			0.6,
			10.5,
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64		
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
				"Scratch",
				"Cut",
				"Vine-Whip",
				"Leer",
				"Bite",
				"Low-Kick",
				"Leech-Seed",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Recycle",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Grass-Whistle",
				"Tickle",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Nasty-Plot",
				"Shadow-Claw",
				"Leaf-Storm",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Grass-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Play-Nice",
				"Confide",
				"Spiky-Shield"
			};
		}
		#endregion
	}
	#endregion

	//Pansage PokemonInstance Class
	#region Pansage
	public class PansageInstance : PokemonInstance
	{
		#region Pansage Constructors
		/// <summary>
		/// Pansage Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PansageInstance(string nickname, int level)
		: base(
				511,
				SpeciesPansage.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Builder only waiting for a Level
		/// </summary>
		public PansageInstance(int level)
		: base(
				511,
				SpeciesPansage.Instance, // PokemonInstance Species
				"Pansage", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansage Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Pansage() : base(
			511,
			SpeciesPansage.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}