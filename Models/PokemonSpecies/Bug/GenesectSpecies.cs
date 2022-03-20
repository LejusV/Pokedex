using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Genesect Species to store common natural stats of all Genesects
	#region GenesectSpecies
	public class GenesectSpecies : PokemonSpecies
	{
#nullable enable
		private static GenesectSpecies? _instance = null;
#nullable restore
        public static GenesectSpecies Instance => _instance ?? (_instance = new GenesectSpecies());

		#region GenesectSpecies Constructor
		public GenesectSpecies() : base(
			649,
			"Genesect",
			Bug.Instance, Steel.Instance,
			1.5,
			82.5,
			new PokemonStats(
				71, // HPs
				120, 95, // Attack & Defense
				120, 95, // Spacial Attack & Defense
				99 // Speed
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
				"Fly",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Flash",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Zap-Cannon",
				"Lock-On",
				"Giga-Drain",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Metal-Sound",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gravity",
				"U-Turn",
				"Last-Resort",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"X-Scissor",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Gunk-Shot",
				"Iron-Head",
				"Magnet-Bomb",
				"Bug-Bite",
				"Charge-Beam",
				"Hone-Claws",
				"Flame-Charge",
				"Simple-Beam",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Techno-Blast",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}