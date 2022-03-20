using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pansage Species to store common natural stats of all Pansages
	#region PansageSpecies
	public class PansageSpecies : PokemonSpecies
	{
#nullable enable
		private static PansageSpecies? _instance = null;
#nullable restore
        public static PansageSpecies Instance => _instance ?? (_instance = new PansageSpecies());

		#region PansageSpecies Constructor
		public PansageSpecies() : base(
			511,
			"Pansage",
			Grass.Instance,
			0.6,
			10.5,
			new PokemonStats(
				50, // HPs
				53, 48, // Attack & Defense
				53, 48, // Spacial Attack & Defense
				64 // Speed
			)			
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
}