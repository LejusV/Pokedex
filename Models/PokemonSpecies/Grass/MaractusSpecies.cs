using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Maractus Species to store common natural stats of all Maractuss
	#region MaractusSpecies
	public class MaractusSpecies : PokemonSpecies
	{
#nullable enable
		private static MaractusSpecies? _instance = null;
#nullable restore
        public static MaractusSpecies Instance => _instance ?? (_instance = new MaractusSpecies());

		#region MaractusSpecies Constructor
		public MaractusSpecies() : base(
			556,
			"Maractus",
			Grass.Instance,
			1.0,
			28.0,
			new PokemonStats(
				75, // HPs
				86, 67, // Attack & Defense
				106, 67, // Spacial Attack & Defense
				60 // Speed
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
				"Pin-Missile",
				"Peck",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Petal-Dance",
				"Toxic",
				"Double-Team",
				"Rest",
				"Substitute",
				"Snore",
				"Cotton-Spore",
				"Protect",
				"Spikes",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Ingrain",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Needle-Arm",
				"Hyper-Voice",
				"Grass-Whistle",
				"Bullet-Seed",
				"Aerial-Ace",
				"Bounce",
				"Acupressure",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Drain-Punch",
				"Energy-Ball",
				"Grass-Knot",
				"Wood-Hammer",
				"After-You",
				"Round",
				"Cotton-Guard",
				"Petal-Blizzard",
				"Grassy-Terrain",
				"Confide",
				"Spiky-Shield"
			};
		}
		#endregion
	}
	#endregion
}