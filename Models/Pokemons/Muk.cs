using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Muk Specie to store common natural stats of every {'abilities': ['stench', 'sticky-hold', 'poison-touch'], 'base_experience': 175, 'height': 12, 'id': 89, 'moves': ['pound', 'fire-punch', 'ice-punch', 'thunder-punch', 'body-slam', 'disable', 'flamethrower', 'hyper-beam', 'strength', 'mega-drain', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'harden', 'minimize', 'bide', 'self-destruct', 'sludge', 'fire-blast', 'poison-gas', 'acid-armor', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'zap-cannon', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'torment', 'memento', 'facade', 'focus-punch', 'taunt', 'brick-break', 'secret-power', 'rock-tomb', 'block', 'shock-wave', 'natural-gift', 'payback', 'fling', 'poison-jab', 'dark-pulse', 'focus-blast', 'giga-impact', 'mud-bomb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'round', 'incinerate', 'belch', 'confide', 'venom-drench', 'infestation', 'power-up-punch'], 'name': 'muk', 'stats': {'hp': 105, 'attack': 105, 'defense': 75, 'special-attack': 65, 'special-defense': 100, 'speed': 50}, 'types': ['poison'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'arms', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ベトベトン', 'roomaji': 'Betbeton', 'ko': '질뻐기', 'zh-Hant': '臭臭泥', 'fr': 'Grotadmorv', 'de': 'Sleimok', 'es': 'Muk', 'it': 'Muk', 'en': 'Muk', 'ja': 'ベトベトン', 'zh-Hans': '臭臭泥'}, 'genera': {'ja-Hrkt': 'ヘドロポケモン', 'ko': '진흙포켓몬', 'zh-Hant': '污泥寶可夢', 'fr': 'Pokémon Dégueu', 'de': 'Schlamm', 'es': 'Pokémon Lodo', 'it': 'Pokémon Melma', 'en': 'Sludge Pokémon', 'ja': 'ヘドロポケモン', 'zh-Hans': '污泥宝可梦'}}
	public class SpecieMuk : PokemonSpecie
	{
#nullable enable
		private static SpecieMuk? _instance = null;
#nullable restore
        public static SpecieMuk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMuk();
                }
                return _instance;
            }
        }

		public SpecieMuk() : base(
			"Muk",
			105, // HPs
			105, 75, // Attack & Defense
			65, 100, // Special Attack & Defense
			50			
		) {}
	}


	//Muk Pokemon Class
	public class Muk : Pokemon
	{

		public Muk(string nickname, int level)
		: base(
				89,
				SpecieMuk.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Muk() : base(
			89,
			SpecieMuk.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}