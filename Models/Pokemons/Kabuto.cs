using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kabuto Specie to store common natural stats of every {'abilities': ['swift-swim', 'battle-armor', 'weak-armor'], 'base_experience': 71, 'height': 5, 'id': 140, 'moves': ['scratch', 'sand-attack', 'body-slam', 'take-down', 'double-edge', 'leer', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'absorb', 'mega-drain', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'harden', 'confuse-ray', 'reflect', 'bide', 'waterfall', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'sandstorm', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'knock-off', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'mud-shot', 'water-pulse', 'brine', 'natural-gift', 'wring-out', 'rock-polish', 'earth-power', 'captivate', 'stealth-rock', 'aqua-jet', 'hone-claws', 'smack-down', 'round', 'scald', 'confide'], 'name': 'kabuto', 'stats': {'hp': 30, 'attack': 80, 'defense': 90, 'special-attack': 55, 'special-defense': 45, 'speed': 55}, 'types': ['rock', 'water'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'armor', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'カブト', 'roomaji': 'Kabuto', 'ko': '투구', 'zh-Hant': '化石盔', 'fr': 'Kabuto', 'de': 'Kabuto', 'es': 'Kabuto', 'it': 'Kabuto', 'en': 'Kabuto', 'ja': 'カブト', 'zh-Hans': '化石盔'}, 'genera': {'ja-Hrkt': 'こうらポケモン', 'ko': '껍질포켓몬', 'zh-Hant': '甲殼寶可夢', 'fr': 'Pokémon Carapace', 'de': 'Schaltier', 'es': 'Pokémon Marisco', 'it': 'Pokémon Crostaceo', 'en': 'Shellfish Pokémon', 'ja': 'こうらポケモン', 'zh-Hans': '甲壳宝可梦'}}
	public class SpecieKabuto : PokemonSpecie
	{
#nullable enable
		private static SpecieKabuto? _instance = null;
#nullable restore
        public static SpecieKabuto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKabuto();
                }
                return _instance;
            }
        }

		public SpecieKabuto() : base(
			"Kabuto",
			30, // HPs
			80, 90, // Attack & Defense
			55, 45, // Special Attack & Defense
			55			
		) {}
	}


	//Kabuto Pokemon Class
	public class Kabuto : Pokemon
	{

		public Kabuto(string nickname, int level)
		: base(
				140,
				SpecieKabuto.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kabuto() : base(
			140,
			SpecieKabuto.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}