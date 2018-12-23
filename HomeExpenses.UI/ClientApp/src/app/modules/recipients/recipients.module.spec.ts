import { RecipientsModule } from './recipients.module';

describe('RecipientsModule', () => {
  let recipientsModule: RecipientsModule;

  beforeEach(() => {
    recipientsModule = new RecipientsModule();
  });

  it('should create an instance', () => {
    expect(recipientsModule).toBeTruthy();
  });
});
